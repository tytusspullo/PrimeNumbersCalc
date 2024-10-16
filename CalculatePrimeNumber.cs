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
        CalculationResult _lastCalculationResult = null;
        long _prime = 0;
        DateTime _whenFound = DateTime.MinValue;

        public CalculatePrimeNumber(CalculationResult lastCalculationResult)
        {
            _lastCalculationResult = lastCalculationResult;
        }

        public CalculationResult Calculate()
        {
            //CalculationResult calcResult = calculationResult;
            bool primeNumberWasCalculated = false;

            TimeSpan timeLimit = TimeSpan.FromSeconds(10);
            CancellationTokenSource timeoutToken = new CancellationTokenSource(timeLimit);
            CancellationTokenSource manualOperationToken = new CancellationTokenSource();
            CancellationTokenSource linkedTokens = CancellationTokenSource.CreateLinkedTokenSource(timeoutToken.Token, manualOperationToken.Token);

            Task<CalculationResult> calculationTask = Task.Run(() => CalculatePrime(linkedTokens.Token,_lastCalculationResult.CycleNumber++), linkedTokens.Token);
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
            }
            catch (OperationCanceledException)
            {
                //canceled throw exception
            }
            finally
            {
                linkedTokens.Dispose();
                manualOperationToken.Dispose();
                timeoutToken.Dispose();
            }

            return calculationTask.Result;
        }
        CalculationResult CalculatePrime(CancellationToken token,int cycle)
        {
            int startNumber = 2;
            while (!token.IsCancellationRequested)
            {
                if (IsPrime(startNumber))
                {
                    _prime = startNumber;
                    _whenFound = DateTime.Now;
                    startNumber++;
                }
                else
                {
                    startNumber++;
                }

                if (token.IsCancellationRequested)
                    break;
            }

            CalculationResult result = new CalculationResult();
            result.CycleNumber = cycle;
            result.LastPrimeNumber = _prime;
            result.WhenPrimeNumberWasFound = _whenFound;
            return result;
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
