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
    
    public partial class METER_REF
    {
        public int METER_ID { get; set; }
        public string TYP_MET { get; set; }
        public short MET_ISPOL_ID { get; set; }
        public Nullable<short> VID_EN_ID { get; set; }
        public short ZN_MET { get; set; }
        public Nullable<short> ZND_MET { get; set; }
        public Nullable<short> POV_INT { get; set; }
        public Nullable<short> POV_INT1 { get; set; }
        public Nullable<short> POV_INT2 { get; set; }
        public Nullable<short> NAP_UCH { get; set; }
        public Nullable<decimal> PRECISE_ID { get; set; }
        public Nullable<short> FAZ { get; set; }
        public Nullable<short> PROMET { get; set; }
        public Nullable<int> CITEL_MET_ID { get; set; }
        public Nullable<int> CITEL_CNT { get; set; }
        public Nullable<int> PROM_MET_ID { get; set; }
        public Nullable<int> PROM_CNT { get; set; }
        public string REMET { get; set; }
    
        public virtual MET_ISPOL_REF MET_ISPOL_REF { get; set; }
        public virtual PRECISE_REF PRECISE_REF { get; set; }
        public virtual VID_EN_REF VID_EN_REF { get; set; }
    }
}
