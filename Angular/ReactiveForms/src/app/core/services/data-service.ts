import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class DataService {
  public jobTitles: Array<string>;
  public companyNames: Array<string>;

  constructor() {
    this.jobTitles = [
      'Software Engineer - 1',
      'Software Engineer - 2',
      'Software Engineer - 3',
      'Senior Software Engineer - 1',
      'Senior Software Engineer - 2',
      'Senior Software Engineer - 3',
    ];
    this.companyNames = [
      'Euromonitor',
      'Super Euromonitor',
      'The one and only Euromonitor',
      'EMI',
      'Amazing EMI',
    ];
  }

  public getJobTitles(): Array<string> {
    return this.jobTitles;
  }

  public getCompanyNames(): Array<string> {
    return this.companyNames;
  }
}
