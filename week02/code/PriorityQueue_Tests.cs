using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Verify if the Enqueue and Dequeue works correctly    
    // // Expected Result: mango, banana, beans, rice, maca
    // Defect(s) Found: Problems in code PriorityQueue.cs, I change index to 0, removed - 1 in "index < _queue.Count" implemented the remove at
    public void TestPriorityQueue_1()
    {
        var mango = new PriorityItem("Mango", 20);
        var banana = new PriorityItem("Banana", 15);
        var beans = new PriorityItem("Beans", 13);
        var rice = new PriorityItem("Rice", 5);
        var maca = new PriorityItem("Maca", 2);
        
        PriorityItem[] expectedResult = [mango, banana, beans, rice, maca];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(maca.Value, maca.Priority);
        priorityQueue.Enqueue(rice.Value, rice.Priority);
        priorityQueue.Enqueue(mango.Value, mango.Priority);
        priorityQueue.Enqueue(banana.Value, banana.Priority);
        priorityQueue.Enqueue(beans.Value, beans.Priority);

        int i=0;
        for (; i < 5 ; i++)
        {
            var itemIn = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, itemIn);
        }
    }

    [TestMethod]
    // Scenario: More one item with the same priority number
    // Expected Result: mango, cotton, banana, strawberry, beans, rice, maca
    // Defect(s) Found: Removed '=' of 'index <= _queue.Count'
    public void TestPriorityQueue_2()
    {
        var mango = new PriorityItem("Mango", 20);
        var cotton = new PriorityItem("Cotton", 20);
        var banana = new PriorityItem("Banana", 15);
        var strawberry = new PriorityItem("Strawberry", 15);
        var beans = new PriorityItem("Beans", 13);
        var rice = new PriorityItem("Rice", 5);
        var maca = new PriorityItem("Maca", 2);
        
        PriorityItem[] expectedResult = [mango, cotton, banana, strawberry, beans, rice, maca];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(maca.Value, maca.Priority);
        priorityQueue.Enqueue(rice.Value, rice.Priority);
        priorityQueue.Enqueue(mango.Value, mango.Priority);
        priorityQueue.Enqueue(cotton.Value, cotton.Priority);
        priorityQueue.Enqueue(banana.Value, banana.Priority);
        priorityQueue.Enqueue(strawberry.Value, strawberry.Priority);
        priorityQueue.Enqueue(beans.Value, beans.Priority);

        int i=0;
        for (; i < 5 ; i++)
        {
            var itemIn = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i].Value, itemIn);
        }
    }


    [TestMethod]
    // Scenario: The queue is empty
    // Expected Result: a error
    // Defect(s) Found: none
    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();
        
        for (int i=0; i < 5 ; i++)
        {
            var itemIn = priorityQueue.Dequeue();
            Assert.Fail();
        } 
    }

    // Add more test cases as needed below.
}