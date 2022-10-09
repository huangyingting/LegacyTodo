## LegacyTodo

Demo application created for cloud migration

TodoWeb
==============

Todo ASP.net web app consumes TodoWCFService

TodoWCFService
==============

Hostable WCF service that can be consumed by the TodoWeb.

The WCF service, available at ~/TodoService.svc provides the following operations:

- GetTodoItems - gets a list of todo items
- CreateTodoItem - creates a new todo item
- EditTodoItem - updates a todo item
- DeleteTodoItem - deletes a todo item
