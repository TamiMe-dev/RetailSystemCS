namespace DalTest;
using DO;
using DalApi;

public static class Initialization
{
    private static IDal s_dal;
    private static void createProduct()
    {
        s_dal.Product.Create(new Product(0, "Liquid Foundation", Categories.FaceMakeup, 150, 200));
        s_dal.Product.Create(new Product(0, "Pressed Powder", Categories.FaceMakeup, 70, 150));
        s_dal.Product.Create(new Product(0, "Concealer", Categories.FaceMakeup, 65, 155));
        s_dal.Product.Create(new Product(0, "Blush", Categories.FaceMakeup, 48, 250));
        s_dal.Product.Create(new Product(0, "Bronzer", Categories.FaceMakeup, 212, 100));
        s_dal.Product.Create(new Product(0, "Highlighter", Categories.FaceMakeup, 130, 88));
        s_dal.Product.Create(new Product(0, "Face Primer", Categories.FaceMakeup, 189, 85));
        s_dal.Product.Create(new Product(0, "Setting Spray", Categories.FaceMakeup, 200, 95));
        s_dal.Product.Create(new Product(0, "BB Cream", Categories.FaceMakeup, 280, 120));
        s_dal.Product.Create(new Product(0, "CC Cream", Categories.FaceMakeup, 145, 80));
        s_dal.Product.Create(new Product(0, "Mascara", Categories.EyeMakeup, 150, 150));
        s_dal.Product.Create(new Product(0, "Eyeliner", Categories.EyeMakeup, 22, 50));
        s_dal.Product.Create(new Product(0, "Eye Pencil", Categories.EyeMakeup, 14, 80));
        s_dal.Product.Create(new Product(0, "Single Eyeshadow", Categories.EyeMakeup, 15, 150));
        s_dal.Product.Create(new Product(0, "Eyeshadow Palette", Categories.EyeMakeup, 220, 50));
        s_dal.Product.Create(new Product(0, "Eyebrow Gel", Categories.EyeMakeup, 13, 88));
        s_dal.Product.Create(new Product(0, "Liquid Eyeshadow", Categories.EyeMakeup, 18, 85));
        s_dal.Product.Create(new Product(0, "Eyeshadow Primer", Categories.EyeMakeup, 20, 95));
        s_dal.Product.Create(new Product(0, "False Eyelashes", Categories.EyeMakeup, 28, 120));
        s_dal.Product.Create(new Product(0, "Lash Glue", Categories.EyeMakeup, 14, 80));
        s_dal.Product.Create(new Product(0, "Matte Lipstick", Categories.LipMakeup, 15, 150));
        s_dal.Product.Create(new Product(0, "Glossy Lipstick", Categories.LipMakeup, 22, 50));
        s_dal.Product.Create(new Product(0, "Lip Gloss", Categories.LipMakeup, 14, 80));
        s_dal.Product.Create(new Product(0, "Lip Liner", Categories.LipMakeup, 15, 150));
        s_dal.Product.Create(new Product(0, "Lip Balm", Categories.LipMakeup, 22, 50));
        s_dal.Product.Create(new Product(0, "Liquid Lipstick", Categories.LipMakeup, 13, 88));
        s_dal.Product.Create(new Product(0, "Lip Tint", Categories.LipMakeup, 18, 85));
        s_dal.Product.Create(new Product(0, "Moisturizing Lipstick", Categories.LipMakeup, 20, 95));
        s_dal.Product.Create(new Product(0, "Lip Scrub", Categories.LipMakeup, 28, 120));
        s_dal.Product.Create(new Product(0, "Lip Primer", Categories.LipMakeup, 14, 80));
        s_dal.Product.Create(new Product(0, "Moisturizer", Categories.Skincare, 150, 150));
        s_dal.Product.Create(new Product(0, "Night Cream", Categories.Skincare, 220, 50));
        s_dal.Product.Create(new Product(0, "Face Serum", Categories.Skincare, 140, 80));
        s_dal.Product.Create(new Product(0, "Exfoliating Scrub", Categories.Skincare, 150, 150));
        s_dal.Product.Create(new Product(0, "Face Mask", Categories.Skincare, 220, 50));
        s_dal.Product.Create(new Product(0, "Toner", Categories.Skincare, 130, 88));
        s_dal.Product.Create(new Product(0, "Facial Cleanser", Categories.Skincare, 180, 85));
        s_dal.Product.Create(new Product(0, "Clay Mask", Categories.Skincare, 200, 95));
        s_dal.Product.Create(new Product(0, "Facial Mist", Categories.Skincare, 280, 120));
        s_dal.Product.Create(new Product(0, "Face Oil", Categories.Skincare, 140, 80));
        s_dal.Product.Create(new Product(0, "Foundation Brush", Categories.MakeupToolsAndAccessories, 45, 200));
        s_dal.Product.Create(new Product(0, "Blush Brush", Categories.MakeupToolsAndAccessories, 70, 150));
        s_dal.Product.Create(new Product(0, "Eyeshadow Brush", Categories.MakeupToolsAndAccessories, 65, 155));
        s_dal.Product.Create(new Product(0, "Beauty Blender Sponge", Categories.MakeupToolsAndAccessories, 48, 250));
        s_dal.Product.Create(new Product(0, "Eyebrow Comb", Categories.MakeupToolsAndAccessories, 21, 100));
        s_dal.Product.Create(new Product(0, "Tweezers", Categories.MakeupToolsAndAccessories, 13, 88));
        s_dal.Product.Create(new Product(0, "Pencil Sharpener", Categories.MakeupToolsAndAccessories, 18, 85));
        s_dal.Product.Create(new Product(0, "Makeup Bag", Categories.MakeupToolsAndAccessories, 20, 95));
        s_dal.Product.Create(new Product(0, "Magnifying Mirror", Categories.MakeupToolsAndAccessories, 28, 120));
        s_dal.Product.Create(new Product(0, "Lip Brush", Categories.MakeupToolsAndAccessories, 14, 80));

    }
    private static void createSale()
    {
        s_dal.Sale.Create(new Sale(0,0,15,100,true, new DateTime(2024,10,15),new DateTime(2024,11,15)));
        s_dal.Sale.Create(new Sale(0, 0, 25, 90, false, new DateTime(2024, 04, 15), new DateTime(2024,05, 25)));
        s_dal.Sale.Create(new Sale(0, 0, 30, 45, false, new DateTime(2024, 09, 15), new DateTime(2024, 12, 20)));
        s_dal.Sale.Create(new Sale(0, 0, 18, 50, true, new DateTime(2024, 05, 02), new DateTime(2024, 10, 15)));
    }
    private static void createCustomer()
    {
        s_dal.Customer.Create(new Customer(328157516,"yael Cohen", "Modiin Ilit", "0533116878"));
        s_dal.Customer.Create(new Customer(214787673, "Tamar Biton", "Modiin Ilit", "0583235240"));
        s_dal.Customer.Create(new Customer(327802228, "Tami Medan", "Modiin Ilit", "0548562881")); 
    }
    public static void Initialize() 
    {
        s_dal = DalApi.Factory.Get;
        createCustomer();
        createProduct();
        createSale();
    }
}
