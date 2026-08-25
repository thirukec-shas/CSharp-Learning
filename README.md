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
