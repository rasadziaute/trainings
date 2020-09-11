import { Injectable } from '@angular/core';
import { HttpHeaders, HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Observable, of, throwError } from 'rxjs';
import { Employee } from './employee';
import { catchError } from 'rxjs/operators';
const httpOptions = {
  header: new HttpHeaders({ 'Content-Type': 'application/json' })
};

const baseUrl = 'http://localhost:3000/Employee';
@Injectable({
  providedIn: 'root'
})

export class EmployeeService {


  // private handleError<T>(operation = 'operation', result?: T) {
  //   return (error: any): Observable<T> => {
  //     console.log(error);
  //     return of(result as T);
  //   };
  // }


  private handleError(errorResonse: HttpErrorResponse) {
    if (errorResonse.error instanceof ErrorEvent) {
       console.log('Client Side Error', errorResonse.error);
    } else {
      console.log('Server Side Error', errorResonse.error);
    }
    return throwError('their is a problem in your code');

  }
  constructor(private http: HttpClient) { }
  getEmployees(): Observable<Employee[]> {
    return this.http.get<Employee[]>(baseUrl).pipe(catchError(this.handleError));
  }

  getEmployeeById(id: number): Observable<Employee> {
    const url = `${baseUrl}/${id}`;
    return this.http.get<Employee>(url).pipe(catchError(this.handleError));
  }
  addEmployee(emp): Observable<Employee> {
    return this.http.post<Employee>(baseUrl, emp);
  }
  deleteEmployee(id): Observable<Employee>{
    const url = `${baseUrl}/${id}`;
    return this.http.delete<Employee>(url)
      .pipe(catchError(this.handleError));
 }

}





