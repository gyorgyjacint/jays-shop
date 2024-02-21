# jays-shop
A webshop project <br>
<b>Under development</b>

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
 
## Setup
- <b>npm i</b> on frontend directories
- <b>docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=yourStrong(!)Password" -p 1433:1433 -d mcr.microsoft.com/mssql/server</b>
  - Docker Desktop needed
- In Server/Jaysbe directory:
  - Create secret.json according to sample
  - <b>dotnet ef database update</b>
  - <b>dotnet run</b>
- In frontend directories:
  - <b>npm run start</b>

## Reference images 
![image](https://github.com/gyorgyjacint/jays-shop/assets/55077329/59a716c1-ae8d-4875-8400-ccd031b5c30e)
![image](https://github.com/gyorgyjacint/jays-shop/assets/55077329/410b4fb8-5800-4d37-a75c-4b47f11d7d12)
![image](https://github.com/gyorgyjacint/jays-shop/assets/55077329/1f1ad4c5-8f21-4569-a3c6-4d1e7967e9f3)
![image](https://github.com/gyorgyjacint/jays-shop/assets/55077329/513dea11-34e9-448c-9604-4410dacc03ea)
![image](https://github.com/gyorgyjacint/jays-shop/assets/55077329/193b4a24-f2f1-4bd3-aaa2-1441e4609257)

