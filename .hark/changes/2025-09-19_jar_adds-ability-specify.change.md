---
title: Adds ability to specify file name and type when calling FileService.Create
pr_link: https://github.com/stripe/stripe-dotnet/pull/3171
is_breaking: true
released_in_version: 49.0.0
---

* ⚠️ Changes `FileCreateOptions`.`File` from a `Stream` to a `MultipartFileContent` type.  This type lets you optionally specify a `Name` and `Type` to use when creating the file.
