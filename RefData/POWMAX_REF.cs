//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RefData
{
    using System;
    using System.Collections.ObjectModel;
    
    public partial class POWMAX_REF
    {
        public POWMAX_REF()
        {
            this.POWMAXZ_REF = new ObservableCollection<POWMAXZ_REF>();
        }
    
        public decimal POWMAX_ID { get; set; }
        public string NPOWM { get; set; }
        public Nullable<decimal> PLOW { get; set; }
        public Nullable<decimal> PHIGH { get; set; }
        public string NPOWMAX { get; set; }
    
        public virtual ObservableCollection<POWMAXZ_REF> POWMAXZ_REF { get; set; }
    }
}
