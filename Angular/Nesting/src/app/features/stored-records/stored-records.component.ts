import { Component, OnInit, Input, OnChanges } from '@angular/core';
import { Employee } from 'src/app/core/models/employee.model';

@Component({
  selector: 'app-stored-records',
  templateUrl: './stored-records.component.html',
  styleUrls: ['./stored-records.component.scss']
})
export class StoredRecordsComponent implements OnInit {
  @Input() employees: Employee[];

  constructor() { }

  ngOnInit(): void {
  }
}
