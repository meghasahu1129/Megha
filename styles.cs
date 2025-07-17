/* Reset and Base Styles */
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}

body {
    font-family: 'Inter', sans-serif;
    line-height: 1.6;
    color: #333;
    overflow-x: hidden;
}

.container {
    max-width: 1200px;
    margin: 0 auto;
    padding: 0 20px;
}

/* Navigation */
.navbar {
    position: fixed;
    top: 0;
    width: 100%;
    background: rgba(255, 255, 255, 0.95);
    backdrop-filter: blur(10px);
    z-index: 1000;
    transition: all 0.3s ease;
    border-bottom: 1px solid rgba(0, 0, 0, 0.1);
}

.nav-container {
    max-width: 1200px;
    margin: 0 auto;
    padding: 0 20px;
    display: flex;
    justify-content: space-between;
    align-items: center;
    height: 80px;
}

.nav-logo h2 {
    color: #2563eb;
    font-size: 1.5rem;
    font-weight: 700;
}

.nav-logo span {
    color: #6b7280;
    font-size: 0.9rem;
    font-weight: 400;
}

.nav-menu {
    display: flex;
    list-style: none;
    gap: 2rem;
}

.nav-menu a {
    text-decoration: none;
    color: #374151;
    font-weight: 500;
    transition: color 0.3s ease;
    position: relative;
}

.nav-menu a:hover {
    color: #2563eb;
}

.nav-menu a::after {
    content: '';
    position: absolute;
    width: 0;
    height: 2px;
    bottom: -5px;
    left: 0;
    background-color: #2563eb;
    transition: width 0.3s ease;
}

.nav-menu a:hover::after {
    width: 100%;
}

.hamburger {
    display: none;
    flex-direction: column;
    cursor: pointer;
}

.hamburger span {
    width: 25px;
    height: 3px;
    background: #374151;
    margin: 3px 0;
    transition: 0.3s;
}

/* Hero Section */
.hero {
    min-height: 100vh;
    background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
    display: flex;
    align-items: center;
    padding-top: 80px;
    color: white;
    position: relative;
    overflow: hidden;
}

.hero::before {
    content: '';
    position: absolute;
    top: 0;
    left: 0;
    right: 0;
    bottom: 0;
    background: url('data:image/svg+xml,<svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 100 100"><defs><pattern id="grain" width="100" height="100" patternUnits="userSpaceOnUse"><circle cx="25" cy="25" r="1" fill="rgba(255,255,255,0.1)"/><circle cx="75" cy="75" r="1" fill="rgba(255,255,255,0.1)"/><circle cx="50" cy="10" r="0.5" fill="rgba(255,255,255,0.05)"/></pattern></defs><rect width="100" height="100" fill="url(%23grain)"/></svg>');
    opacity: 0.3;
}

.hero-container {
    display: grid;
    grid-template-columns: 1fr 1fr;
    gap: 4rem;
    align-items: center;
    position: relative;
    z-index: 1;
}

.hero-content h1 {
    font-size: 3.5rem;
    font-weight: 700;
    line-height: 1.2;
    margin-bottom: 1rem;
}

.highlight {
    background: linear-gradient(45deg, #fbbf24, #f59e0b);
    -webkit-background-clip: text;
    -webkit-text-fill-color: transparent;
    background-clip: text;
}

.hero-subtitle {
    font-size: 1.5rem;
    font-weight: 500;
    margin-bottom: 1rem;
    opacity: 0.9;
}

.hero-description {
    font-size: 1.1rem;
    margin-bottom: 2rem;
    opacity: 0.8;
    line-height: 1.7;
}

.hero-buttons {
    display: flex;
    gap: 1rem;
    margin-bottom: 3rem;
}

.btn {
    padding: 1rem 2rem;
    border-radius: 50px;
    text-decoration: none;
    font-weight: 600;
    transition: all 0.3s ease;
    display: inline-block;
    text-align: center;
    border: none;
    cursor: pointer;
    font-size: 1rem;
}

.btn-primary {
    background: linear-gradient(45deg, #f59e0b, #fbbf24);
    color: white;
    box-shadow: 0 4px 15px rgba(245, 158, 11, 0.4);
}

.btn-primary:hover {
    transform: translateY(-2px);
    box-shadow: 0 8px 25px rgba(245, 158, 11, 0.6);
}

.btn-secondary {
    background: transparent;
    color: white;
    border: 2px solid rgba(255, 255, 255, 0.3);
}

.btn-secondary:hover {
    background: rgba(255, 255, 255, 0.1);
    border-color: rgba(255, 255, 255, 0.5);
}

.hero-stats {
    display: flex;
    gap: 2rem;
}

.stat h3 {
    font-size: 2rem;
    font-weight: 700;
    color: #fbbf24;
}

.stat p {
    font-size: 0.9rem;
    opacity: 0.8;
}

.hero-image {
    position: relative;
}

.hero-image img {
    width: 100%;
    height: 500px;
    object-fit: cover;
    border-radius: 20px;
    box-shadow: 0 20px 40px rgba(0, 0, 0, 0.3);
}

/* Section Headers */
.section-header {
    text-align: center;
    margin-bottom: 4rem;
}

.section-header h2 {
    font-size: 2.5rem;
    font-weight: 700;
    margin-bottom: 1rem;
    color: #1f2937;
}

.section-header p {
    font-size: 1.1rem;
    color: #6b7280;
    max-width: 600px;
    margin: 0 auto;
}

/* About Section */
.about {
    padding: 6rem 0;
    background: #f9fafb;
}

.about-content {
    display: grid;
    grid-template-columns: 1fr 1fr;
    gap: 4rem;
    align-items: center;
}

.about-text h3 {
    font-size: 2rem;
    font-weight: 600;
    margin-bottom: 1.5rem;
    color: #1f2937;
}

.about-text p {
    font-size: 1.1rem;
    line-height: 1.8;
    margin-bottom: 1.5rem;
    color: #4b5563;
}

.skills-grid {
    display: grid;
    grid-template-columns: repeat(2, 1fr);
    gap: 1rem;
    margin-top: 2rem;
}

.skill-item {
    display: flex;
    align-items: center;
    gap: 0.5rem;
    padding: 0.75rem;
    background: white;
    border-radius: 10px;
    box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
    transition: transform 0.3s ease;
}

.skill-item:hover {
    transform: translateY(-2px);
}

.skill-item i {
    color: #2563eb;
    font-size: 1.2rem;
}

.about-image img {
    width: 100%;
    height: 400px;
    object-fit: cover;
    border-radius: 15px;
    box-shadow: 0 15px 30px rgba(0, 0, 0, 0.2);
}

/* Services Section */
.services {
    padding: 6rem 0;
    background: white;
}

.services-grid {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(350px, 1fr));
    gap: 2rem;
}

.service-card {
    background: white;
    padding: 2.5rem;
    border-radius: 15px;
    box-shadow: 0 10px 30px rgba(0, 0, 0, 0.1);
    transition: all 0.3s ease;
    border: 1px solid #e5e7eb;
}

.service-card:hover {
    transform: translateY(-5px);
    box-shadow: 0 20px 40px rgba(0, 0, 0, 0.15);
}

.service-icon {
    width: 60px;
    height: 60px;
    background: linear-gradient(45deg, #2563eb, #3b82f6);
    border-radius: 15px;
    display: flex;
    align-items: center;
    justify-content: center;
    margin-bottom: 1.5rem;
}

.service-icon i {
    font-size: 1.5rem;
    color: white;
}

.service-card h3 {
    font-size: 1.5rem;
    font-weight: 600;
    margin-bottom: 1rem;
    color: #1f2937;
}

.service-card p {
    color: #6b7280;
    line-height: 1.7;
    margin-bottom: 1.5rem;
}

.service-card ul {
    list-style: none;
}

.service-card li {
    padding: 0.5rem 0;
    color: #4b5563;
    position: relative;
    padding-left: 1.5rem;
}

.service-card li::before {
    content: '✓';
    position: absolute;
    left: 0;
    color: #10b981;
    font-weight: bold;
}

/* Portfolio Section */
.portfolio {
    padding: 6rem 0;
    background: #f9fafb;
}

.portfolio-grid {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(350px, 1fr));
    gap: 2rem;
}

.portfolio-item {
    background: white;
    border-radius: 15px;
    overflow: hidden;
    box-shadow: 0 10px 30px rgba(0, 0, 0, 0.1);
    transition: transform 0.3s ease;
}

.portfolio-item:hover {
    transform: translateY(-5px);
}

.portfolio-image {
    height: 200px;
    overflow: hidden;
}

.portfolio-image img {
    width: 100%;
    height: 100%;
    object-fit: cover;
    transition: transform 0.3s ease;
}

.portfolio-item:hover .portfolio-image img {
    transform: scale(1.05);
}

.portfolio-content {
    padding: 2rem;
}

.portfolio-content h3 {
    font-size: 1.3rem;
    font-weight: 600;
    margin-bottom: 1rem;
    color: #1f2937;
}

.portfolio-content p {
    color: #6b7280;
    line-height: 1.6;
    margin-bottom: 1.5rem;
}

.portfolio-results {
    display: flex;
    gap: 1rem;
    flex-wrap: wrap;
}

.result {
    background: linear-gradient(45deg, #10b981, #059669);
    color: white;
    padding: 0.5rem 1rem;
    border-radius: 20px;
    font-size: 0.9rem;
    font-weight: 500;
}

/* Testimonials Section */
.testimonials {
    padding: 6rem 0;
    background: white;
}

.testimonials-grid {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
    gap: 2rem;
}

.testimonial-card {
    background: #f9fafb;
    padding: 2rem;
    border-radius: 15px;
    border-left: 4px solid #2563eb;
}

.testimonial-content p {
    font-style: italic;
    color: #4b5563;
    line-height: 1.7;
    margin-bottom: 1.5rem;
    font-size: 1.1rem;
}

.testimonial-author {
    display: flex;
    align-items: center;
    gap: 1rem;
}

.testimonial-author img {
    width: 50px;
    height: 50px;
    border-radius: 50%;
    object-fit: cover;
}

.testimonial-author h4 {
    color: #1f2937;
    font-weight: 600;
}

.testimonial-author span {
    color: #6b7280;
    font-size: 0.9rem;
}

/* Contact Section */
.contact {
    padding: 6rem 0;
    background: linear-gradient(135deg, #1f2937 0%, #374151 100%);
    color: white;
}

.contact .section-header h2,
.contact .section-header p {
    color: white;
}

.contact-content {
    display: grid;
    grid-template-columns: 1fr 1fr;
    gap: 4rem;
    margin-top: 3rem;
}

.contact-info h3 {
    font-size: 1.8rem;
    margin-bottom: 1rem;
}

.contact-info p {
    margin-bottom: 2rem;
    opacity: 0.9;
    line-height: 1.7;
}

.contact-item {
    display: flex;
    align-items: center;
    gap: 1rem;
    margin-bottom: 1rem;
}

.contact-item i {
    color: #fbbf24;
    font-size: 1.2rem;
    width: 20px;
}

.social-links {
    display: flex;
    gap: 1rem;
    margin-top: 2rem;
}

.social-links a {
    width: 40px;
    height: 40px;
    background: rgba(255, 255, 255, 0.1);
    border-radius: 50%;
    display: flex;
    align-items: center;
    justify-content: center;
    color: white;
    transition: all 0.3s ease;
}

.social-links a:hover {
    background: #fbbf24;
    transform: translateY(-2px);
}

.contact-form {
    background: rgba(255, 255, 25
