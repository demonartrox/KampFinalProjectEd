using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules //bu bir araç olduğu için interface yapmadık. gerek yok.
    {
        public static IResult Run(params IResult[] logics) //logic iş kuralı demek. [] array oluyor.
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic; //eğer hata varsa hata yani kurala uymayan döndürülür.
                }
            }

            return null;
        }
    }
}
