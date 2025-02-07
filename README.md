```sh
# 建立 gitignore
dotnet new gitignore

# 建立 Solution
dotnet new sln --name Bookify

# 建立 Class Library (.NET8)
dotnet new classlib -f net8.0 -o src/Bookify.Domain

# 加入 Project 到 Solution
dotnet sln add src/Bookify.Domain/Bookify.Domain.csproj
```



