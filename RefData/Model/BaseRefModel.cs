using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefData
{
    public abstract class BaseRefModel
    {
        public abstract string Nameref { get; }
        public abstract string Objects { get; }
    }

    public partial class METER_REF: BaseRefModel
    {
        private static string _nameref = "METER_REF";
        public override string Nameref
        {
            get { return _nameref; }
        }
        public override string Objects 
        {
            get { return TYP_MET; }
        }
    }

    public partial class BRON_ORG_REF: BaseRefModel
    {
        private static string _nameref = "BRON_ORG_REF";
        public override string Nameref 
        {
            get { return _nameref; } 
        }
        public override string Objects 
        {
            get { return BRON_ORG_NAME; }
        }
    }

    public partial class FACTORKZ_REF: BaseRefModel
    {
        private static string _nameref = "FACTORKZ_REF";
        public override string Nameref 
        {
            get { return _nameref; } 
        }
        public override string Objects 
        {
            get { return POTR; }
        }
    }
}
