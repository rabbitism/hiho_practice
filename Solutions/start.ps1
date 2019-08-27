param($a)
dotnet new console -n "$a"
Set-Location $a
New-Item input
New-Item README.MD