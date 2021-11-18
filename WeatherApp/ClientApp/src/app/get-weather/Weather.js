"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
exports.Temperature = exports.Clouds = exports.Wind = exports.Weather = void 0;
var Weather = /** @class */ (function () {
    function Weather(name, time, wind, visibility, clouds, main, tempcelcius) {
        this.name = name;
        this.time = time;
        this.wind = wind;
        this.visibility = visibility;
        this.clouds = clouds;
        this.main = main;
        this.tempcelcius = tempcelcius;
    }
    return Weather;
}());
exports.Weather = Weather;
var Wind = /** @class */ (function () {
    function Wind(speed, deg, gust) {
        this.speed = speed;
        this.deg = deg;
        this.gust = gust;
    }
    return Wind;
}());
exports.Wind = Wind;
var Clouds = /** @class */ (function () {
    function Clouds(all) {
        this.all = all;
    }
    return Clouds;
}());
exports.Clouds = Clouds;
var Temperature = /** @class */ (function () {
    function Temperature(temp, pressure, humidity) {
        this.temp = temp;
        this.pressure = pressure;
        this.humidity = humidity;
    }
    return Temperature;
}());
exports.Temperature = Temperature;
//# sourceMappingURL=Weather.js.map