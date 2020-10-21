import { s1TemplatePage } from './app.po';

describe('s1 App', function() {
  let page: s1TemplatePage;

  beforeEach(() => {
    page = new s1TemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
