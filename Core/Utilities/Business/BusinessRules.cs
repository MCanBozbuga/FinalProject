using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        //params verdiğin zaman içersini istediğin kadar IResult verebilirsin. , ile ayırarak
        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic;   //Parametreyle gönderilen iş kurallarından , başarısız olanı business'e. Şu logic hatalı diye gönderiyoruz. Logic dediğimiz => Kuralın kendisi.
                }
            }
            return null;
        }
        
    }
}
