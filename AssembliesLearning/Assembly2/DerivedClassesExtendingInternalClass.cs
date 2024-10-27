

using Assembly1;

namespace Assembly2
{
     internal class DCChildOfClassFromAnotherAssm : BaseClass
    {
        public void AccessModifiersDemo()
        {
            DCChildOfClassFromAnotherAssm dcChild = new DCChildOfClassFromAnotherAssm();
            dcChild.BC_PrivateField1 = 10;
            dcChild.BC_InternalField = 30;
            dcChild.BC_PrivateProtectedField = 30;
            dcChild.BC_ProtectedField = 20;
            dcChild.BC_InternalProtectedField = 40;
            dcChild.BC_PublicField = 30;
        }
    }

    internal class StandAlonePublicClassinAssembly2
    {
        public void AccessModifiersDemo()
        {
            BaseClass bc = new BaseClass();
            bc.BC_PrivateField1 = 10;
            bc.BC_InternalField = 20;
            bc.BC_PrivateProtectedField = 30;
            bc.BC_ProtectedField = 40;
            bc.BC_InternalProtectedField = 30;
            bc.BC_PublicField = 30;
        }
    }
}
