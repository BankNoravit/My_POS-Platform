(function (window, undefined) {
  'use strict';

  //=============//
  // Nav Level 2 //
  //=============//
  let submenu = document.querySelectorAll('.sub-menu');

  if (submenu) {
    submenu.forEach(items => {
      items.addEventListener('click', () => {

        // Side Navigation
        if (items.getAttribute('id') == 'sideNavSalesAndMarketing') {
          let hasId = document.querySelector('#panelSalesAndMarketing');
          hasId.classList.toggle('show-panel');
          hasId.classList.add('hide-panel');
          if (hasId.classList.contains('show-panel')) {
            hasId.classList.remove('hide-panel');
          }
        }

        if (items.getAttribute('id') == 'sideNavProcurementManagement') {
          let hasId = document.querySelector('#panelProcurementManagement');
          hasId.classList.toggle('show-panel');
          hasId.classList.add('hide-panel');
          if (hasId.classList.contains('show-panel')) {
            hasId.classList.remove('hide-panel');
          }
        }

        if (items.getAttribute('id') == 'sideNavInventoryManagement') {
          let hasId = document.querySelector('#panelInventoryManagement');
          hasId.classList.toggle('show-panel');
          hasId.classList.add('hide-panel');
          if (hasId.classList.contains('show-panel')) {
            hasId.classList.remove('hide-panel');
          }
        }

        if (items.getAttribute('id') == 'sideNavFinanceAndAccount') {
          let hasId = document.querySelector('#panelFinanceAndAccount');
          hasId.classList.toggle('show-panel');
          hasId.classList.add('hide-panel');
          if (hasId.classList.contains('show-panel')) {
            hasId.classList.remove('hide-panel');
          }
        }

        if (items.getAttribute('id') == 'sideNavOrganization') {
          let hasId = document.querySelector('#panelOrganization');
          hasId.classList.toggle('show-panel');
          hasId.classList.add('hide-panel');
          if (hasId.classList.contains('show-panel')) {
            hasId.classList.remove('hide-panel');
          }
        }

        if (items.getAttribute('id') == 'sideNavAdmin') {
          let hasId = document.querySelector('#panelAdmin');
          hasId.classList.toggle('show-panel');
          hasId.classList.add('hide-panel');
          if (hasId.classList.contains('show-panel')) {
            hasId.classList.remove('hide-panel');
          }
        }

        if (items.getAttribute('id') == 'filterAddColumn') {
          let hasId = document.querySelector('#panelAddColumn');
          hasId.classList.toggle('show-panel');
          hasId.classList.add('hide-panel');
          if (hasId.classList.contains('show-panel')) {
            hasId.classList.remove('hide-panel');
          }
        }
      })
    })
  }

  //=============//
  // Close Panel //
  //=============//
  let btnClose = document.querySelectorAll('a.btn-close');

  btnClose.forEach(items => {
    items.addEventListener('click', () => {

      // Close Panel
      if (items.offsetParent.getAttribute('id') == 'panelSalesAndMarketing') {
        let panel = document.getElementById('panelSalesAndMarketing');
        panel.classList.add('hide-panel');
        panel.classList.remove('show-panel');
      }

      if (items.offsetParent.getAttribute('id') == 'panelProcurementManagement') {
        let panel = document.getElementById('panelProcurementManagement');
        panel.classList.add('hide-panel');
        panel.classList.remove('show-panel');
      }

      if (items.offsetParent.getAttribute('id') == 'panelInventoryManagement') {
        let panel = document.getElementById('panelInventoryManagement');
        panel.classList.add('hide-panel');
        panel.classList.remove('show-panel');
      }

      if (items.offsetParent.getAttribute('id') == 'panelFinanceAndAccount') {
        let panel = document.getElementById('panelFinanceAndAccount');
        panel.classList.add('hide-panel');
        panel.classList.remove('show-panel');
      }

      if (items.offsetParent.getAttribute('id') == 'panelOrganization') {
        let panel = document.getElementById('panelOrganization');
        panel.classList.add('hide-panel');
        panel.classList.remove('show-panel');
      }

      if (items.offsetParent.getAttribute('id') == 'panelAdmin') {
        let panel = document.getElementById('panelAdmin');
        panel.classList.add('hide-panel');
        panel.classList.remove('show-panel');
      }

      if (items.offsetParent.getAttribute('id') == 'panelAddColumn') {
        let panel = document.getElementById('panelAddColumn');
        panel.classList.add('hide-panel');
        panel.classList.remove('show-panel');
      }

    })
  })


  let btnCloseBody = document.querySelectorAll('button.btn-close-panel');
  console.log(btnCloseBody);
  btnCloseBody.forEach(items => {
    items.addEventListener('click', () => {
      if (items.offsetParent.getAttribute('id') == 'panelAddColumn') {
        let panel = document.getElementById('panelAddColumn');
        panel.classList.add('hide-panel');
        panel.classList.remove('show-panel');
      }
    })
  })

})(window);


