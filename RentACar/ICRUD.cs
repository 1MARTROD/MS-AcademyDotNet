using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar
{
    public interface ICRUD<T>
    {
        //   public T Create(T t);
        public T Read(int id);
        //  public void Update(T t);
        // public void Delete(T t);
    }
}
