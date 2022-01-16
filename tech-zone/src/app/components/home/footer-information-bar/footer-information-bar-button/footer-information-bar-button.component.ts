import { Component, OnInit, Input } from '@angular/core';
import { FooterInformationBarButton } from '../../../../interfaces/information-bar/informationBarButtons';

@Component({
  selector: 'app-footer-information-bar-button',
  templateUrl: './footer-information-bar-button.component.html',
  styleUrls: ['./footer-information-bar-button.component.css']
})
export class FooterInformationBarButtonComponent implements OnInit {
  @Input() buttonInfo: FooterInformationBarButton;

  constructor() { }

  ngOnInit(): void {
  }

}
