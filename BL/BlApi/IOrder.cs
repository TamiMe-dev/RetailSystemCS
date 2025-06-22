﻿using BO;
namespace BlApi;

public interface IOrder
{

    //List<SaleInProduct> AddProductToOrder(int code, int amount);
    List<SaleInProduct> AddProductToOrder(Order order, int code, int amount);

    void CalcTotalPriceForProduct(ProductInOrder productInOrder);
    
    void CalcTotalPrice(Order order);
    
    void DoOrder(Order order);
    
    //void SearchSaleForProduct(int code, bool isFavorite);
}
