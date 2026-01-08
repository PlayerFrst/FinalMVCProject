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

        public static class Category 
        { 
            public const int NameMinLength = 2; 
            public const int NameMaxLength = 30; 

            public const int DescriptionMaxLength = 200;
        }
        public static class User 
        {   
            public const int FirstNameMinLength = 2; 
            public const int FirstNameMaxLength = 50; 

            public const int LastNameMinLength = 2;
            public const int LastNameMaxLength = 50;
        }
        public static class Review 
        {   
            public const int CommentMaxLength = 300;

            public const int MinRating = 1;
            public const int MaxRating = 5;
        }
        public static class Manufacturer 
        { 
            public const int NameMinLength = 2;
            public const int NameMaxLength = 50; 

            public const int CountryMinLength = 2; 
            public const int CountryMaxLength = 50;
        }
    }
}
