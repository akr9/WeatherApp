export class Weather {
  constructor(public name: string, public time: string, public wind: Wind, public visibility: string, public clouds: Clouds, public main: Temperature, public tempcelcius: Temperature, ) { }
}

export class Wind {
  constructor(public speed: string, public deg: string, public gust: string) { }
}

export class Clouds {
  constructor(public all: string) { }
}

export class Temperature {
  constructor(public temp: string, public pressure: string, public humidity: string) { }
}
