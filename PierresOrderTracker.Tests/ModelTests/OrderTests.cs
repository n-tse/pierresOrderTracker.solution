using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PierresOrderTracker.Models;
using System;

namespace PierresOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("description", "title", 1, "date");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string description = "bread";
      string title = "title";
      int price = 1;
      string date = "January 1";
      //Act
      Order newOrder = new Order(description, title, price, date);
      string result = newOrder.Description;
      //Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
      string description = "bread";
      string title = "title";
      int price = 1;
      string date = "January 1";
      //Act
      Order newOrder = new Order(description, title, price, date);
      string result = newOrder.Title;
      //Assert
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void GetPrice_ReturnsPrice_Int()
    {
      //Arrange
      string description = "bread";
      string title = "title";
      int price = 1;
      string date = "January 1";
      //Act
      Order newOrder = new Order(description, title, price, date);
      int result = newOrder.Price;
      //Assert
      Assert.AreEqual(price, result);
    }

    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {
      //Arrange
      string description = "bread";
      string title = "title";
      int price = 1;
      string date = "January 1";
      //Act
      Order newOrder = new Order(description, title, price, date);
      string result = newOrder.Date;
      //Assert
      Assert.AreEqual(date, result);
    }
  }
}