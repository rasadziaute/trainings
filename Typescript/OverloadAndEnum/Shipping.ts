import { Weekday } from "./Weekday";
import { DayFormat } from "./DayFormat";

export class Shipping 
{
    weekday = Weekday;
    dayFormat = DayFormat;

    public getShippingDay(currentDay:Weekday, returnFormat:DayFormat):number;

    public getShippingDay(currentDay:Weekday, returnFormat:DayFormat):string;


    public getShippingDay(currentDay:Weekday, returnFormat:DayFormat):any
    {
        let shippingDay:number = this.calculateShippingDay(currentDay)

        if (returnFormat == DayFormat.string) {
            return Weekday[shippingDay];

        }

        if (returnFormat == DayFormat.number) {
            return shippingDay + 1;
        }
    }

    private calculateShippingDay(currentDay:Weekday): number
    {
        if (currentDay == Weekday.Thursday) {
            return 0;
        }
        if (currentDay == Weekday.Friday) {
            return 1;
        }
        else {
            return currentDay + 2;
        }
    }

}


