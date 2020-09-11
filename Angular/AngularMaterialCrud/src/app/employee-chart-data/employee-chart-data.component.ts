import { Component, OnInit } from '@angular/core';
import { Employee } from '../employee';
import { ChartOptions, ChartType, ChartDataSets } from 'chart.js';
import { Label } from 'ng2-charts';
import { EmployeeService } from '../employee.service';

@Component({
  selector: 'app-employee-chart-data',
  templateUrl: './employee-chart-data.component.html',
  styleUrls: ['./employee-chart-data.component.css']
})
export class EmployeeChartDataComponent implements OnInit {

  constructor(private empService: EmployeeService) { }
  emp: Employee[] = [];
  label = 'Achieved';
  isDataLoading = true;
  barChartOptions: ChartOptions = {
    responsive: true,
  };
  barChartLables: Label[] = [];
  barChartType: ChartType = 'bar';
  barChartLegend = true;

  barChartData: ChartDataSets[] = [{ data: [], backgroundColor: []}];
  public getChart() {
    this.barChartData = [{ data: [], backgroundColor: [], label: this.label }];
    this.barChartLables = [];
    const chartData: any[] = [];
    const chartColor: string[] = [];

    this.empService.getEmployees().subscribe((res: any) => {
      this.emp = res;
      this.emp.forEach((chart) => {
        this.barChartLables.push(chart.name);
        chartData.push(chart.id);
        if (this.label === 'Achieved') {
          chartColor.push('rgba(255,165,0,0.5)');
        } else if (this.label === 'NotAchieved') {
          chartColor.push('rgba(255, 0, 0, 0.5)');

        }
      });

      this.barChartData = [{ data: chartData, backgroundColor: chartColor, label: this.label }];
      this.isDataLoading = false;
    }, err => {
        console.log(err);
        this.isDataLoading = false;
    });
  }

  ngOnInit() {
    this.getChart();
  }
  
  changeStatus() {
    this.isDataLoading = true;
    this.getChart();
  }
}
