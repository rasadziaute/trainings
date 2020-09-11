import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, FormControl, Validators } from '@angular/forms';
import { MatDialogRef } from '@angular/material';

@Component({
  selector: 'app-modal-form',
  templateUrl: './modal-form.component.html',
  styleUrls: ['./modal-form.component.css'],
})
export class ModalFormComponent implements OnInit {
  public formGroup: FormGroup;
  private dialogconfig;
  constructor(private fb: FormBuilder, private thisDialogRef: MatDialogRef<ModalFormComponent>) {}

  ngOnInit() {
    this.formGroup = this.fb.group({
      id: new FormControl('', [Validators.required]),
      from: new FormControl('', [Validators.required, Validators.maxLength(20)]),
      to: new FormControl('', [Validators.required, Validators.maxLength(20)]),
      dateCreated: new FormControl(),
      permanentLink: new FormControl('', [Validators.required]),
    });
    this.dialogconfig = {
      height: '300px',
      width: '400px',
    };
  }
  public OnSubmit(): void {
    this.thisDialogRef.close({
      id: this.formGroup.get('id').value,
      from: this.formGroup.get('from').value,
      to: this.formGroup.get('to').value,
      dateCreated: this.formGroup.get('dateCreated').value,
      permanentLink: this.formGroup.get('permanentLink').value,
    });
    this.formGroup.reset();
  }
  public closeDialog(): void {
    this.thisDialogRef.close();
  }
}
