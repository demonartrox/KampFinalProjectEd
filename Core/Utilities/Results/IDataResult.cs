using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //hangi tipi döndüreceğini bana söyle. burada T generic yani tip. T=Iproduct service içindeki "List<Product>"
    public interface IDataResult<T>:IResult //imlemente ederek iresult içindekileri de buraya getirdik.
    {
        T Data { get; } //result içindekinden farklı olarak data da bulundur. bu data ürünler olabilir.
    }
}
