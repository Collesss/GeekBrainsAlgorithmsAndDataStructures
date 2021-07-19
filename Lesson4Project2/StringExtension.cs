using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson4Project2
{
    public static class StringExtension
    {
        public static string Join<T>(IEnumerable<string> IEseparators, IEnumerable<T> values)
        {
            StringBuilder stringBuilder = new StringBuilder();
            string end = string.Empty;
            IEnumerator<string> separators = IEseparators.GetEnumerator();

            foreach (T value in values)
            {
                stringBuilder.Append(value);

                if (!separators.MoveNext())
                {
                    separators.Reset();
                    separators.MoveNext();
                }

                stringBuilder.Append(separators.Current);
                end = separators.Current;
            }

            return stringBuilder.ToString(0, stringBuilder.Length - end.Length);
        }
    }
}
