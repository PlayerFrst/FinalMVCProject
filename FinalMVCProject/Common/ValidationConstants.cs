namespace FinalMVCProject.Common
{
    public class ValidationConstants
    {
        public static class Car 
        {
            public const int BrandMaxLength = 50; 
            public const int BrandMinLength = 2; 

            public const int ModelMaxLength = 50; 
            public const int ModelMinLength = 1;
            
            public const int YearMin = 1900; 
            public const int YearMax = 2050; 
        }
    }
}
