//*************************************************************
// Solution for the ErrorHandling mini-exercise in Exercism.io
//
// ~Spikeyo
//*************************************************************

using System;

namespace ErrorHandlingProject
{
    public static class ErrorHandling
    {
        public static void HandleErrorByThrowingException()
        {
            throw new Exception();
        }

        public static int? HandleErrorByReturningNullableType(string input)
        {
            return int.TryParse(input, out int i) ? (int?)i : null;
        }

        public static bool HandleErrorWithOutParam(string input, out int result)
        { 
            return int.TryParse(input, out result);
        } 

        public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(IDisposable disposableObject)
        {
            using (disposableObject)
            {
                throw new Exception();
            }        
        } 
    }
}
