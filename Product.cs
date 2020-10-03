class Program{
	public static void Main(string[] args){
		Product P = new Product ("Laptop", 45000.00,'E');
	}
}

class Product{
private string productCode;
private string productName;
private double productPrice;
private char categoryCode;
private static int prodCounter = 100;



public string ProductCode{
	get{return productCode;}
	set{productCode=value;}
}
public string ProductName{
	get{return productName;}
	set{productName=value;}
}
public double ProductPrice{
	get{return productPrice;}
	set{productPrice=value;}
}
public char CategoryCode{
	get{return categoryCode;}
	set{categoryCode=value;}
}

private string generateProductCode(char cc){
	prodCounter++;
	string str = categoryCode.ToString()+ prodCounter.ToString();
	return str;
}

public Product(string productName, double productPrice, char categoryCode){
	productCode = generateProductCode(categoryCode);
	this.productName = productName;
	this.productPrice = productPrice;
	this.categoryCode = categoryCode;
}

public Product(string productName, double productPrice){
	
	char cc = 'E';
	productCode = generateProductCode(cc);
	this.productName = productName;
	this.productPrice = productPrice;
}

public  string getProductDetails(){
	return ("Code-"+productCode+",Name-"+productName+",Price-"+productPrice.ToString()+",Category-"+categoryCode.ToString());
}

}