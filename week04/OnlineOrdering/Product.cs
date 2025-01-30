public class Product{
    string _name;
    string _productId;
    float _price;
    int _quantity;

    public Product(string name, string productId, float price, int quantity){
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public float GetTotalPrice(){
        return _price * _quantity;
    }

    public string GetName(){
        return _name;
    }

    public string GetId(){
        return _productId;
    }
}