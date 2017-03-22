# Clean Architecture Practice

(written: March 21, 2017)

Last year, I was able to read Uncle Bob Martin's article titled ["The Clean Architecture"](http://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html). While reading that article I thought that he is just explaining how most software developers do architecture in the real world.

But two days ago, I learned that he is writing a book titled "Clean Architecture"...

And I learned that Matthew Renze has [talks on clean architecture](http://www.matthewrenze.com/presentations.html#clean-architecture). (I have also seen his sample project about a year ago but I forgot about it.)

Then I realized that this "Clean Architecture" idea is new. I have to learn it.


I tried to study Matthew Renze's [sample project](https://github.com/matthewrenze/clean-architecture-demo) through his [slides](http://www.matthewrenze.com/presentations/clean-architecture.pdf) (he has a Pluralsight course on this but I do not have money yet to subscribe)

I also found ["a Clean Architecture in .Net"](https://medium.com/@stephanhoekstra/clean-architecture-in-net-8eed6c224c50#.wwhi7no7o) by Stephan Hoekstra.


## In this practice project...

1. I'm going to try to redo Stephan Hoekstra's ["Contact Real Estate Agent" project](https://github.com/stephanhoekstra/clean-architecture).

2. Because I want to know what TDD is, I will try to write my tests first.

3. Matthew Renze has a module named Specification in his project. I think he is trying to separate the tests for the specification from the unit tests. That is what I'm going to do in my practice project.

- Ahh! In his [Git commits](https://github.com/matthewrenze/clean-architecture-demo/commits/master), he has this: "Added Specification project for acceptance tests". So the Specification module contains the acceptance tests.

4. In Stephan Hoekstra's project, he has this `Interest` entity. But his `House` entity has this:

``` csharp
public IList<Interest> Leads { get;  }
```

What is this `Leads`?

Ahh! So the `Interest` class is a [_"sales lead"_](http://www.investopedia.com/terms/s/sales-lead.asp). I'm going to use `SalesLead` instead of `Interest`

