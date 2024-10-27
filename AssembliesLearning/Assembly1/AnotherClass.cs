namespace Assembly1
{
    public class StandAlonePublicClass
    {
        private int SAPC_PrivateField1;
        protected int SAPC_ProtectedField;
        internal int SAPC_InternalField;
        internal protected int SAPC_InternalProtectedField;
        private protected int SAPC_PrivateProtectedField;
        public int SAPC_PublicField;

        public void AccessModifiersDemo()
        {
            BaseClass ins1 = new BaseClass();
            ins1.BC_PrivateField1 = 10;
            ins1.BC_ProtectedField = 10;
            ins1.BC_PrivateProtectedField = 10;
            ins1.BC_InternalField = 10;
            ins1.BC_InternalProtectedField = 20;
            ins1.BC_PublicField = 10;
        }
    }

    class ChildInternalClass : BaseClass
    {

        public void AccessModifiersDemo()
        {
            ChildInternalClass ins1 = new ChildInternalClass();
            ins1.BC_PrivateField1 = 10;
            ins1.BC_ProtectedField = 10;
            ins1.BC_InternalField = 10;
            ins1.BC_InternalProtectedField = 20;
            ins1.BC_PrivateProtectedField = 10;
            ins1.BC_PublicField = 10;
        }
    }
}
