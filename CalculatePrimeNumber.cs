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
        
        CancellationTokenSource timeoutToken = null;
        CancellationTokenSource manualOperationToken = null;
        CancellationTokenSource linkedTokens = null;
        public event Action OnCancelRequested;

        public CalculatePrimeNumber(CalculationResult lastCalculationResult)
        {
            if (_lastCalculationResult == null)
            {
                _lastCalculationResult = new CalculationResult();
                _lastCalculationResult.CycleNumber = 1;
            }
            else
            {
                _lastCalculationResult = lastCalculationResult;
            }

            TimeSpan timeLimit = TimeSpan.FromSeconds(10);
            timeoutToken = new CancellationTokenSource(timeLimit);
            manualOperationToken = new CancellationTokenSource();
            linkedTokens = CancellationTokenSource.CreateLinkedTokenSource(timeoutToken.Token, manualOperationToken.Token);
        }

        public async Task<CalculationResult> CalculateAsync()
        {
            Task<CalculationResult> calculationTask = Task.Run(() 
                => CalculatePrime(linkedTokens.Token,_lastCalculationResult.CycleNumber++), linkedTokens.Token);
            try
            {
                return await calculationTask;
            }
            catch (OperationCanceledException)
            {
                 return calculationTask.Result;
            }
            finally
            {
                linkedTokens.Dispose();
                manualOperationToken.Dispose();
                timeoutToken.Dispose();
            }
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

        public void CancelManual()
        {
            if (manualOperationToken != null)
            {
                manualOperationToken.Cancel();
            }
        }

    }
}
