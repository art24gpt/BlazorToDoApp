using ToDoAppBlazorServer.Models;
using ToDoAppBlazorServer.Services;

namespace ToDoAppBlazorServer.Tests;

public class TodoServiceTests
{
    [Fact]
    public void Add_ShouldAddItem()
    {
        //Arrange
        var service = new TodoService();

        //Act
        service.Add(new TodoItem("Test item"));
        var result = service.GetAll();

        //Assert
        Assert.Contains(result, x => x.Text == "Test item");
    }

    [Fact]
    public void Complete_ShouldMarkItemAsCompleted()
    {
        //Arrange
        var service = new TodoService();

        //Act
        var item = service.GetAll().First();
        service.Complete(item);

        //Assert
        Assert.True(item.Completed);
    }

    [Fact]
    public void Uncomplete_ShouldMarkItemAsNotCompleted()
    {
        //Arrange
        var service = new TodoService();

        //Act
        var item = service.GetAll().First();
        service.Complete(item);
        service.Uncomplete(item);

        //Assert
        Assert.False(item.Completed);
    }

    [Fact]
    public void Delete_ShouldRemoveItem()
    {
        //Arrange
        var service = new TodoService();

        //Act
        var item = service.GetAll().First();
        service.Delete(item);
        var result = service.GetAll();

        //Assert
        Assert.DoesNotContain(result, x => x.Text == item.Text);
    }
}