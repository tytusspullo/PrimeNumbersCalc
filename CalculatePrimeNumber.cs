using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PrimeNumbersCalculatorGP
{
    public class CalculatePrimeNumber
    {
        CalculationResult _calculationResult = null;
        List<int> primesMarkedInCycle = new List<int>();

        public CalculatePrimeNumber(CalculationResult calculationResult)
        {
            _calculationResult = calculationResult;
        }

        /// <summary>
        /// Prime number was calculated.
        /// </summary>
        /// <returns>True. if calculated.</returns>
        public bool Calculate(out CalculationResult calculationResult)
        {
            bool primeNumberWasCalculated = false;

            TimeSpan timeLimit = TimeSpan.FromMinutes(2);
            CancellationTokenSource timeoutToken = new CancellationTokenSource(timeLimit);
            CancellationTokenSource manualOperationToken = new CancellationTokenSource();
            CancellationTokenSource linkedTokens = CancellationTokenSource.CreateLinkedTokenSource(timeoutToken.Token, manualOperationToken.Token);

            Task<long> calculationTask = Task.Run(() => CalculatePrime(linkedTokens.Token), linkedTokens.Token);
            //Task.Run(() =>
            //{
            //    while (true)
            //    {
            //        if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.C)
            //        {
            //            manualOperationToken.Cancel();
            //            break;
            //        }
            //    }
            //});
            try
            {
                calculationTask.Wait(linkedTokens.Token);
                _calculationResult.LastPrimeNumber = calculationTask.Result;
                //Console.WriteLine($"Calculation completed. Result: {calculationTask.Result}");
            }
            catch (OperationCanceledException)
            {
                //Console.WriteLine("Calculation canceled either manually or after timeout.");
            }
            finally
            {
                linkedTokens.Dispose();
                manualOperationToken.Dispose();
                timeoutToken.Dispose();
            }

            calculationResult = _calculationResult;
            return primeNumberWasCalculated;
        }
        long CalculatePrime(CancellationToken token)
        {
            int startNumber = 2;
            while (!token.IsCancellationRequested)
            {
                if (IsPrime(startNumber))
                {
                    primesMarkedInCycle.Add(startNumber);
                    startNumber++;
                }
                else
                {
                    startNumber++;
                }

                if (token.IsCancellationRequested)
                    break;
            }

            if (primesMarkedInCycle.Count > 0)
                return primesMarkedInCycle.Last();
            else
                return 0;
        }

        private bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
