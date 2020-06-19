import { Injectable } from '@angular/core';
import { Employee } from '../models/employee.model';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
    private url = '/assets/employee.json';

    constructor(private httpClient: HttpClient) { }

    public getEmployees(): Observable<Employee[]> {
      return this.httpClient.get<Employee[]>(this.url);
    }
}
