import { Shipping } from "./Shipping";
import { Weekday } from "./Weekday";
import { DayFormat } from "./DayFormat";

let orderShipping = new Shipping();

console.log('Your order will be shipped on: ' + orderShipping.getShippingDay(Weekday.Monday, DayFormat.string));

console.log('Your order will be shipped on: ' + orderShipping.getShippingDay(Weekday.Monday, DayFormat.number));

console.log('Your order will be shipped on: ' + orderShipping.getShippingDay(Weekday.Friday, DayFormat.string));

console.log('Your order will be shipped on: ' + orderShipping.getShippingDay(Weekday.Friday, DayFormat.number));