import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterOutlet } from '@angular/router';
import { ShopCartComponent } from './components/shop-cart/shop-cart.component';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, ShopCartComponent, RouterOutlet],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'FEA-P010';
}
