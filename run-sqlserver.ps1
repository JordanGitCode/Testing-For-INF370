$ContainerName = "sqlserver2022"
$SaPassword = "YourStrong@Passw0rd"
$Image = "mcr.microsoft.com/mssql/server:2022-latest"

docker run -e "ACCEPT_EULA=Y" `
  -e "MSSQL_SA_PASSWORD=$SaPassword" `
  -p 1433:1433 `
  --name $ContainerName `
  --hostname $ContainerName `
  -d $Image
