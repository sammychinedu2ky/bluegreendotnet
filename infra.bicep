param location string = resourceGroup().location

resource myserverfarm 'Microsoft.Web/serverfarms@2022-09-01' = {
  name: 'samsons-serverfarm'
  location: location
  sku: {
   name: 'S1'
  }
  kind: 'linux'
}

resource myserverfarmapp 'Microsoft.Web/sites@2022-09-01' = {
  name: 'mvpbluegreen'
  location: location
  properties:{
    serverFarmId: myserverfarm.id
  }
  resource mystaging 'slots@2022-09-01' = {
    name: 'staging'
    location: location
    properties:{
      serverFarmId: myserverfarm.id
    }
  }
}


