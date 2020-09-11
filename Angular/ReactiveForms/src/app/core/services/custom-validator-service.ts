import { Injectable } from '@angular/core';
import {
  FormGroup,
  AbstractControl,
  ValidatorFn,
  Form,
  FormControl,
  ValidationErrors,
} from '@angular/forms';
import { DataService } from './data-service';

@Injectable({
  providedIn: 'root',
})
export class CustomValidatorService {
  constructor(private dataService: DataService) {}

  public validateName(): ValidatorFn {
    return (control: FormControl): ValidationErrors => {
      let validation;
      if (control.value) {
        validation =
          (control.value as string) === (control.value as string).toUpperCase();
      }
      return validation ? null : { capitalLetters: true };
    };
  }

  public validateCompanyName(): ValidatorFn {
    return (control: FormControl): ValidationErrors => {
      if (
        this.dataService.getCompanyNames().includes(control.value as string)
      ) {
        return null;
      }
      return { notValidCompany: true };
    };
  }
}
