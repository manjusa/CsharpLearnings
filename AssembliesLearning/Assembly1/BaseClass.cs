namespace Assembly1
{
    public class BaseClass
    {
        private int BC_PrivateField1;
        protected int BC_ProtectedField;
        internal int BC_InternalField;
        internal protected int BC_InternalProtectedField;
        private protected int BC_PrivateProtectedField;
        public int BC_PublicField;

        public void AccessModifiersDemo()
        {
            // Accessible within the same assembly
            BC_PrivateField1 = 10;
            BC_ProtectedField = 10;
            BC_InternalField = 10;
            BC_InternalProtectedField = 20;
            BC_PrivateProtectedField = 30;
            BC_PublicField = 40;
        }
    }

}
