//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан инструментальным средством
//     В случае повторного создания кода изменения, внесенные в этот файл, будут потеряны.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Products
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

    public class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA apa)
        {
            Console.WriteLine(this + " Interacts with " + apa);
        }
    }
}

