using System;
class Product{
	private string name;
	private string productCode;
	private string brandName;
	private int stockLeft;
	private double price;
	private DateTime expiryDate;
	
	public string Name{
	get{return name;}
	set{name=value;}}
	
	public string ProductCode{
		get{return productCode;}
		set{productCode=value;}
	}
	
	public string BrandName{
		get{return brandName;}
		set{brandName=value;}
	}
	
	public int StockLeft{
		get{return stockLeft;}
		set{stockLeft=value;}
	}
	
	public double Price{
		get{return price;}
		set{price=value;}
	}
	
	public DateTime ExpiryDate{
		get{return expiryDate;}
		set{expiryDate=value;}
	}
	
	public Product(){}
	
	public Product(string name, string productCode,string brandName,int stockLeft,double price,DateTime expiryDate ){
		this.name=name;
		this.productCode=productCode;
		this.brandName=brandName;
		this.stockLeft=stockLeft;
		this.price=price;
		this.expiryDate=expiryDate;
	}
	
	public override string ToString(){
		return ("Name:"+name+"\nProductCode:"+productCode+"\nBrandName:"+brandName+"\nStockLeft:"+stockLeft+"\nPrice:"+price+"\nExpiryDate:"+expiryDate);
		
	}
	
	public bool Equals(Product p){
		if(this.name.ToLower()==p.name.ToLower() && this.productCode.ToLower()==p.productCode.ToLower())
			return true;
		else
			return false;
	}
	
	class FinalProductProgram1{
		public static void Main(string[] args){
			Product pr = new Product("Sonal","113","brand",5,50.00,DateTime.Now);
			
		}
		
	}
}