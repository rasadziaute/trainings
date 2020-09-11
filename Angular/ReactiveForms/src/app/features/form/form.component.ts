import { Component, OnInit } from '@angular/core';
import {
  FormGroup,
  FormBuilder,
  Validators,
  FormArray,
  FormControl,
} from '@angular/forms';
import { CustomValidatorService } from 'src/app/core/services/custom-validator-service';
import { DataService } from 'src/app/core/services/data-service';

@Component({
  selector: 'app-form',
  templateUrl: './form.component.html',
  styleUrls: ['./form.component.scss'],
})
export class FormComponent implements OnInit {
  public reactiveForm: FormGroup;
  public jobTitles: Array<string>;

  constructor(
    private formBuilder: FormBuilder,
    private validator: CustomValidatorService,
    private dataService: DataService
  ) {}

  ngOnInit(): void {
    this.reactiveForm = this.buildForm();
    this.jobTitles = this.dataService.getJobTitles();
  }

  buildForm(): FormGroup {
    return this.formBuilder.group({
      name: ['', [Validators.required, this.validator.validateName()]],
      email: ['', [Validators.required, Validators.email]],
      additionalForm: this.formBuilder.array([this.buildAdditionForm()]),
    });
  }

  buildAdditionForm(): FormGroup {
    return this.formBuilder.group({
      companyName: [
        '',
        [Validators.required, this.validator.validateCompanyName()],
      ],
      jobTitle: ['', [Validators.required]],
      totalExperience: ['', [Validators.required]],
      fromDate: [''],
      toDate: [''],
      skills: [''],
    });
  }

  get additionalForm(): FormArray {
    return this.reactiveForm.get('additionalForm') as FormArray;
  }

  addAdditionalForm(): void {
    this.additionalForm.push(this.buildAdditionForm());
  }
}
