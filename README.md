# jays-shop
A webshop project

## Feature goals
- Authentication / authorization
  - Email confirmation (?)
- Admin site
  - Creating, editing: users, products, categories
  - Handling orders
- Client site
  - Categorized products
  - Search
  - Sorting
  - Placing orders
  - Recieving confirmation email (?)

## Tech stack
- Backend
  - C#, ASP.NET
  - Entity Frameworks
  - MSSQL
- Frontend
  - JavaScript
  - React
  - MaterialUI

## Other
- secrets.json must have:
  - ConnectionString
  - IssueAudience
  - IssueSign
  - IssuerSigningKey
  - AdminEmail
  - AdminPw
