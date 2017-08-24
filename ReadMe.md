

### Project is about trying to see if we can get RavenDb to work under NetStandard 2.0

NOTE: there are 2 parts to this experiment.

1. Class library (which will end up being a nuget pacakge) - requires the use of `RavenDb.Client` nuget package.
2. An xUnit project which takes advantage of RavenDb.Database (in memory db).


First problem: Can't get `RavenDb.Client` to install into a standard NS20 class library. The latest is `3.5.4` but that is not signed or some crap, so it doesn't work or install. The latest _patch_ version is `3.5.5-patch-35216` and that _should_ work in NS20. At least it did in a NS1.6 project.
  /\____ try both normal and then pre-release versions.

Second problem: Can't install any `RavenDb.Database` or `RavenDB.Tests.Helpers` package into an xUnit project either.


2017-08-24 11:12pm AESTD.