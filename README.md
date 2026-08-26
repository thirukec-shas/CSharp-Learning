IEnumerable vs IQueryable
# IEnumerable vs IQueryable

## What is IEnumerable?

Used mainly for working with data in memory.

## What is IQueryable?

Used to build queries that can be translated and executed by
the underlying data source.

## Practical Example

Employee table contains large amounts of data.

IQueryable allows filtering to be performed by SQL Server
before the data is returned to the application.

## Performance

Avoid loading unnecessary records into application memory.

## Interview Questions

1. What is IEnumerable?
2. What is IQueryable?
3. What is deferred execution?
4. What happens when ToList() is called?
5. Where does filtering happen?
6. Is IQueryable always faster?
7. What is expression tree?

**Thread**: Thread is an execution unit used to perform work in an application. It is managed by the Operating system.

**Task**: A Task represents an asynchronous operation or Pieace of work that may complete in the future.

****Thread Pool:** Thread pool is a collection of reusable thread managed by .NET. It helps execute multiple tasks without creating a new thread for every task. **

**What is Task<T>?
Task represents the work, and <T> represents the result we get when the work is completed.**

Async/Await – are used to handle asynchronous operations. They allow the application to continue other work instead of blocking a thread while waiting for an operation complete.
Or

Async and await are used to handle asynchronous operations. When we are waiting for an operation like a database or API call, await allows the thread to be released instead of blocking it unnecessarily. Once the operation is completed, the method continues.

Where do you use async/await in your project?
We mainly use async and await for I/O operations such as database calls, API calls and file operations. For example, in our Web API, the controller calls the service asynchronously, and the service calls the repository using await. This prevents unnecessary thread blocking while waiting for the database response


