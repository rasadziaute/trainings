import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
    name: 'getExponentialValue'
})

export class GetExponentialValuePipe implements PipeTransform{

    transform(value: number, power?: number): number {
        if (!power) {
            power = 2;
        }
        return Math.pow(value, power);
    }

}
