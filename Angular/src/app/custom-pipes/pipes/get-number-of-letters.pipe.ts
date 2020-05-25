import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
    name: 'getNumberOfLetters'
})

export class GetNumberOfLettersPipe implements PipeTransform{

    transform(value: string): number {
        let count = 0;
        let letter: any;
        const regX = /[a-z]/g;
        for (let i = 0; i < value.length; i++) {
            letter = value[i].match(regX);
            if (letter) {
                count = count + 1;
            }
        }
        return count;
    }

}
