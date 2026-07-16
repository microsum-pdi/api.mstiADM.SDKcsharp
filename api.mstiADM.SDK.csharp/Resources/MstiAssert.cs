using System;

namespace api.mstiADM.SDK.csharp.Resources
{
    /// <summary>
    /// Classe de garantia (Guard Clauses) para o SDK. 
    /// Garante que premissas sejam verdadeiras sem o comportamento destrutivo do Trace.Assert.
    /// </summary>
    public static class MstiAssert
    {
        /// <summary>
        /// Garante que uma condição lógica seja verdadeira. 
        /// Lança <see cref="MstiAssertException"/> caso seja falsa.
        /// </summary>
        public static void Check(bool condition, string message)
        {
            if (!condition) throw new MstiAssertException(message);
        }
        
        /// <summary>
        /// Garante que um objeto não seja nulo.
        /// Lança <see cref="MstiAssertException"/> caso seja nulo.
        /// </summary>
        public static void Check<T>(T obj, string message) where T : class
        {
            if (obj is null)  throw new MstiAssertException(nameof(obj), message);
        }
    }

    public class MstiAssertException : Exception
    {
        public MstiAssertException() { }
        public MstiAssertException(string message) : base(message) { }
        public MstiAssertException(string name, string message) : base($"[{name}] - {message}") { }
    }
}