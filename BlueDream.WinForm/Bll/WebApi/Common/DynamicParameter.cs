using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueDream.WinForm
{
    public sealed class DynamicParameter : DynamicObject
    {
        private readonly Dictionary<string, object> m_Properties;

        public DynamicParameter(Dictionary<string, object> p_Properties)
        {
            m_Properties = p_Properties;
        }

        public override IEnumerable<string> GetDynamicMemberNames()
        {
            return m_Properties.Keys;
        }

        public override bool TryGetMember(GetMemberBinder p_Binder, out object p_Result)
        {
            if (m_Properties.ContainsKey(p_Binder.Name))
            {
                p_Result = m_Properties[p_Binder.Name];
                return true;
            }
            else
            {
                p_Result = null;
                return false;
            }
        }

        public override bool TrySetMember(SetMemberBinder p_Binder, object p_Value)
        {
            if (m_Properties.ContainsKey(p_Binder.Name))
            {
                m_Properties[p_Binder.Name] = p_Value;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

