namespace Math;

public class ProductOfNumbers
{
    private List<int> products;

    public ProductOfNumbers()
    {
        products = new List<int>() { 1 };
    }

    public void Add(int num)
    {
        if (num == 0)
        {
            products = new List<int> { 1 };
        }
        else
        {
            products.Add(products[products.Count - 1] * num);
        }
    }

    public int GetProduct(int k)
    {
        if (k >= products.Count)
        {
            return 0;
        }

        return products[products.Count - 1] / products[products.Count - 1 - k];
    }
}