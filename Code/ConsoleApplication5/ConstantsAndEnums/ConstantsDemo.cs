namespace ExampPrep.ConstantsAndEnums
{
    /// <summary>
    /// Constant fields and locals aren't variables and may not be modified. 
    /// Constants can be numbers, Boolean values, strings, or a null reference. 
    /// Don’t create a constant to represent information that you expect to change at any time. 
    /// </summary>
    class ConstantsDemo
    {
        public const int FreezingTemp = 32;

        public void ChangeConst(int newFreezingTemp)
        {
            //will cause compiler error
            //FreezingTemp = newFreezingTemp; 
        }
    }
}
