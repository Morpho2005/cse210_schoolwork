public class Order{
    List<Product> _products = new List<Product>();
    Customer _customer;

    public void AddProduct(string name, string productId, float price, int quantity){
        Product product = new Product(name, productId, price, quantity);
        _products.Add(product);
    }

    public float GetTotalPrice(){
        float price = 0;
        for (int i=0;i<_products.Count;i++){
            price += _products[i].GetTotalPrice();
        }
        if (_customer.IsInUSA()){
            price += 5;
        } else {
            price += 35;
        }
        return price;
    }

    public string GetPackingLabel(){
        string label = "";
        foreach (Product p in _products){
            label = $"{label}{p.GetName}, {p.GetId}; ";
        }
        return label;
    }

    public string GetShippingLabel(){
        return $"{_customer.GetName}, {_customer.GetAddress}";
    }
}