import { Component, OnInit, ViewChild, Inject } from '@angular/core';
import { IUrlLink } from '../urlink';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator } from '@angular/material/paginator';
import { MatDialog } from '@angular/material';
import { ModalFormComponent } from 'src/app/modal-form/modal-form.component';
import { ProductService } from 'src/app/product.service';

@Component({
  selector: 'app-url-details',
  templateUrl: './url-details.component.html',
  styleUrls: ['./url-details.component.css'],
})
export class UrlDetailsComponent implements OnInit {
  title = 'Angular Material Session!!';
  // step 1
  dataSource: any;
  // step 2
  public urlLinks: IUrlLink[];
  @ViewChild(MatPaginator, { static: true }) paginator: MatPaginator;
  public displayedColumns: string[] = ['id', 'from', 'to', 'dateCreated', 'permanentLink'];
  constructor(@Inject(ProductService) private product, public dialog: MatDialog) {
    // step 3
    this.urlLinks = [
      {
        id: 19228,
        from: '/heath_and_wellness',
        to: '/danone-group-in-heath-and-wellness/report',
        dateCreated: new Date().getDate(),
        permanentLink: true,
      },
      {
        id: 19229,
        from: '/heinekens_acquisition_of_femsa_increases',
        to: '/heinekens_acquisition_of_femsa_increases',
        dateCreated: new Date().getDate(),
        permanentLink: true,
      },
      {
        id: 19230,
        from: '/herbal_traditional_products',
        to: '/herbal_traditional_products',
        dateCreated: new Date().getDate(),
        permanentLink: true,
      },
      {
        id: 19231,
        from: '/home_care',
        to: '/amway-corp-in-home-care/report',
        dateCreated: new Date().getDate(),
        permanentLink: true,
      },
      {
        id: 19232,
        from: '/hong-kong-china',
        to: '/100-home-delivery-take-away-in-hong-kong-china',
        dateCreated: new Date().getDate(),
        permanentLink: true,
      },
      {
        id: 19233,
        from: '/hot-drinks',
        to: '/associated-british-foods-plc-in-hot-drinks/report',
        dateCreated: new Date().getDate(),
        permanentLink: true,
      },
      {
        id: 19233,
        from: '/hot-drinks',
        to: '/associated-british-foods-plc-in-hot-drinks/report',
        dateCreated: new Date().getDate(),
        permanentLink: true,
      },
      {
        id: 19233,
        from: '/hot-drinks',
        to: '/associated-british-foods-plc-in-hot-drinks/report',
        dateCreated: new Date().getDate(),
        permanentLink: true,
      },
    ];
    if (localStorage.getItem('storedLinks')) {
      this.urlLinks = JSON.parse(localStorage.getItem('storedLinks'));
    }
  }
  // step 5
  ngOnInit() {
    this.bindDataSource(this.urlLinks);
    this.dataSource.paginator = this.paginator;
  }
  // step 4
  private bindDataSource(urlLinks: IUrlLink[]) {
    this.dataSource = new MatTableDataSource<IUrlLink>(urlLinks);
  }

  public openDialog(): void {
    const dialogref = this.dialog.open(ModalFormComponent, {
      //   width:'650px',
      disableClose: false,
    });
    dialogref.afterClosed().subscribe((r) => {
      if (r !== undefined) {
        this.urlLinks.push(Object.assign({}, r));
        console.log(this.urlLinks);
        this.bindDataSource(this.urlLinks);
        localStorage.setItem('storedLinks', JSON.stringify(this.urlLinks));
      }
    });
  }
}
